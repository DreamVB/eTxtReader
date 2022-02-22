using System;
using System.IO;
using DreamVB.Config;
using FilePackNET;

namespace eTxtCompiler
{
    class eTxtcomp
    {
        static void Main(string[] args)
        {
            cfgfile cfg = null;
            FilePackNET.bjPak pak = new bjPak();
            FilePackNET.bjPak.TPageInfo pi = new bjPak.TPageInfo();

            Console.WriteLine("Ben's Simple eTxt Compiler");

            if (args.Length < 1)
            {
                Console.WriteLine("Missing Inut File.");
            }
            else
            {
                if (!File.Exists(args[0]))
                {
                    Console.WriteLine("File Not Found:\n" + args[0]);
                }
                else
                {
                    //Open script file.
                    cfg = new cfgfile(args[0]);

                    string sOutput = cfg.ReadString("output", "file");

                    if (sOutput.Trim().Length == 0)
                    {
                        Console.WriteLine("The books output was not found.");
                    }
                    else
                    {
                        //Get book info
                        string sBookInfo = cfg.ReadString("book-info", "file");

                        if (!File.Exists(sBookInfo))
                        {
                            Console.WriteLine("Book Information File Not Found:\n" + sBookInfo);
                            return;
                        }
                        else
                        {
                            //Add book info to the files package
                            pi.Filename = sBookInfo;
                            pi.PageTitle = "";
                            pak.AddFile(pi);
                        }
                        //Process pages
                        int pages = cfg.ReadInteger("pages", "files");

                        for (int x = 1; x <= pages; x++)
                        {
                            //Read page location
                            pi.Filename = cfg.ReadString("pages", "file" + x.ToString());
                            //Read page title
                            pi.PageTitle = cfg.ReadString("pages", "title" + x.ToString());
                            
                            //Check if page exsits
                            if (File.Exists(pi.Filename))
                            {
                                //Add the file to the pack
                               pak.AddFile(pi);
                            }
                        }
                    }
                    try
                    {
                        //Create the package file
                        pak.CreatePack(sOutput);
                        //Messages to user in console.
                        Console.WriteLine("Finished.");
                        Console.WriteLine("eText Book was saved to: " + sOutput);
                    }
                    catch (Exception ex)
                    {
                        //Write any error message.
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
