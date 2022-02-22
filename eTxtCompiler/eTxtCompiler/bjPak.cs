// Here is a simple class to pack multiple files into one single file.
// it does not support writeing the files dictionary structure as of yet
// This was made as I needed something quick to pack many csv files.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace FilePackNET
{
    class bjPak
    {
        private Version version = new Version(1, 0, 0, 0);
        //Each file info
        public struct TFile
        {
            //Filename
            public string Filename;
            public string PageName;
            //Lenfth of the file
            public int flen;
            //The files data
            public byte[] data;
        }

        public struct TPageInfo
        {
            public string Filename;
            public string PageTitle;
        }

        //Holds each files info
        private List<TFile> FileFrmt;

        private List<TPageInfo> Files = new List<TPageInfo>();

        private byte[] CompressBytes(byte[] Bytes)
        {
            MemoryStream ms = new MemoryStream();

            using (DeflateStream dfs = new DeflateStream(ms, CompressionLevel.Optimal))
            {
                dfs.Write(Bytes, 0, Bytes.Length);
            }

            return ms.ToArray();
        }

        private byte[] Decompress(byte[] Bytes)
        {
            MemoryStream ms_Input = new MemoryStream(Bytes);
            MemoryStream m_Output = new MemoryStream();

            using (DeflateStream dfs = new DeflateStream(ms_Input, CompressionMode.Decompress))
            {
                dfs.CopyTo(m_Output);
            }

            return m_Output.ToArray();
        }


        /// <summary>
        /// Return the number of files
        /// </summary>
        public int FileCount
        {
            get
            {
                return FileFrmt.Count;
            }
        }

        /// <summary>
        /// Remove all file info from FileFrmt List
        /// </summary>
        public void ClearFiles()
        {
            FileFrmt.Clear();
        }

        /// <summary>
        /// Add a single file to the files List
        /// </summary>
        /// <param name="Filename"></param>
        public void AddFile(TPageInfo PageInfo)
        {
            //Check file is found
            if (!File.Exists(PageInfo.Filename))
            {
                throw new Exception("File Not Found:\n" + PageInfo.Filename);
            }
            else
            {
                //Add to files list
                Files.Add(PageInfo);
            }
        }

        /// <summary>
        /// Return File info record
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TFile GetFile(int index)
        {
            return FileFrmt[index];
        }

        /// <summary>
        /// Pack all the files in Files list into a single file
        /// </summary>
        /// <param name="Filename"></param>
        public void CreatePack(string Filename)
        {
            try
            {
                using (var fs = File.Create(Filename))
                {
                    using (BinaryWriter br = new BinaryWriter(fs))
                    {
                        foreach (TPageInfo pi in Files)
                        {
                            //Set for next file
                            br.Write(true);
                            //Extract filename only supported at the moment
                            FileInfo fi = new FileInfo(pi.Filename);
                            //Write filename
                            br.Write(fi.Name);
                            br.Write(pi.PageTitle);
                            //Get file data
                            byte[] data = File.ReadAllBytes(pi.Filename);
                            data = CompressBytes(data);
                            //Write the length of the file
                            br.Write(data.Length);
                            //Write file data bytes to the file
                            br.Write(data);
                        }
                        br.Write(false);
                        br.Close();
                    }

                    fs.Close();
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Opens a pack file and read the contents
        /// </summary>
        /// <param name="Filename"></param>
        public void OpenPack(string Filename)
        {
            TFile f = new TFile();

            try
            {
                //Check if file not found
                if (!File.Exists(Filename))
                {
                    throw new Exception("File Not Found:\n" + Filename);
                }
                else
                {
                    FileFrmt = new List<TFile>();

                    using (var fs = File.OpenRead(Filename))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            //While we have files read and write
                            while (br.ReadBoolean() == true)
                            {
                                //Get filename
                                string lzFile = br.ReadString();
                                f.Filename = lzFile;
                                f.PageName = br.ReadString();
                                //Read file length
                                f.flen = br.ReadInt32();
                                //Resize and set data with the file bytes
                                byte[] data = new Byte[f.flen];
                                //Read the bytes
                                data = br.ReadBytes(f.flen);
                                //Set f.data to bytes
                                f.data = Decompress( data);
                                //Add to FileFrmt record
                                FileFrmt.Add(f);
                            }
                            br.Close();
                        }
                        fs.Close();
                    }

                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
