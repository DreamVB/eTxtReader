// DreamVB.Config Version 1.0.1
// This is a full class for reading and writing to Windows INI Files.
// This project is a raw class uses no Windows API class.
// What's in side this class

// Load config data from a file.
// Load config data from a raw string
// Read and write string values
// Read and write Integer, Double values, Boolean values, Long values
// Read strings that have line breaks and also write strings with line breaks.
// Read and Write binary data to the config file
// Return a collection of selections
// Return a collection of keys form a selection passed.
// Delete selections and all the values and keys
// Check if a selection exists
// Check if a key exists in a selection
// Delete a key and a value
// Save to other filenames
// Update the current loaded config file

// Hope you find this class useful.
// By DreamVB email dreamvb@outlook.com

using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

namespace DreamVB.Config
{
    public class cfgfile
    {
        private string m_config_file = string.Empty;

        private struct TSelction_Pair
        {
            public string Name;
            public string Key;
        }

        private Hashtable ht = null;

        /// <summary>
        /// Constructor to load config file data, Data can be passed as a filename or a string
        /// When ReadFromFile is set to false data is assumed to be read from a string
        /// </summary>
        /// <param name="source"></param>
        /// <param name="ReadFromFile"></param>
        public cfgfile(string source, bool ReadFromFile = true)
        {
            ht = new Hashtable();

            //Read config data from file
            if (ReadFromFile)
            {
                m_config_file = source;
                //Make hash table
                ParseFileConfig(m_config_file);
            }
            else
            {
                //Read config data from string.
                ParseStringConfig(source);
            }
        }

        public cfgfile()
        {
            ht = new Hashtable();
        }

        private string FixKeyName(string KeyName)
        {
            //Uppercase the first letter and lowercase the rest
            return char.ToUpper(KeyName[0]).ToString() + KeyName.Substring(1).ToLower();
        }

        /// <summary>
        /// Loads an config file data from a string
        /// </summary>
        /// <param name="data"></param>
        private void ParseStringConfig(string data)
        {
            StringReader sr;
            string s_line = null;
            string s_selection = string.Empty;
            string s_key = string.Empty;
            string s_val = string.Empty;
            TSelction_Pair pair;
            int s_pos=-1;

            if (data.Length.Equals(0))
            {
                return;
            }

            try
            {
                sr = new StringReader(data);
                //Get first line
                s_line = sr.ReadLine().Trim();

                while (s_line != null)
                {
                    //Check length
                    if (s_line.Length.Equals(0))
                    {
                        continue;
                    }
                    //Skip comments
                    if (s_line[0].Equals(';'))
                    {
                        continue;
                    }

                    //Check for selection.
                    if (s_line.StartsWith("[") && (s_line.EndsWith("]")))
                    {
                        s_selection = s_line.Substring(1, s_line.IndexOf("]") - 1).Trim();
                    }
                    else
                    {
                        //Look for =
                        s_pos = s_line.IndexOf("=");

                        if (s_pos != -1)
                        {
                            //Extract key value name
                            s_key = s_line.Substring(0, s_pos).Trim().ToUpper();
                            //Extract the keys value
                            s_val = s_line.Substring(s_pos + 1).Trim();
                            //Set pair name to selection name
                            pair.Name = s_selection.ToUpper();
                            //Set selection pair key
                            pair.Key = s_key;
                            //Add to the hash list
                            ht.Add(pair, s_val);
                        }
                    }
                    //Fetch next line
                    s_line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //Clear up
            sr.Dispose();
        }

        /// <summary>
        /// Load the config filename
        /// </summary>
        /// <param name="Filename"></param>
        private void ParseFileConfig(string Filename)
        {
            string s_line = string.Empty;
            string s_selection = string.Empty;
            string s_key = string.Empty;
            string s_val = string.Empty;

            int s_pos = (-1);

            TSelction_Pair pair;
            
            //Check if the filename exists
            if (!File.Exists(Filename))
            {
                throw new FileNotFoundException("File Not Found:\n" + Filename);
            }

            try
            {

                using (StreamReader sr = new StreamReader(Filename))
                {
                    //Read till end of file.
                    while(!sr.EndOfStream)
                    {
                        s_line = sr.ReadLine().Trim();

                        //Check length
                        if (s_line.Length.Equals(0))
                        {
                            continue;
                        }
                        //Skip comments
                        if (s_line[0].Equals(';'))
                        {
                            continue;
                        }

                        //Check for selection.
                        if (s_line.StartsWith("[") && (s_line.EndsWith("]")))
                        {
                            s_selection = s_line.Substring(1, s_line.IndexOf("]") - 1).Trim();
                        }
                        else
                        {
                            //Look for =
                            s_pos = s_line.IndexOf("=");

                            if (s_pos != -1)
                            {
                                //Extract key value name
                                s_key = s_line.Substring(0, s_pos).Trim().ToUpper();
                                //Extract the keys value
                                s_val = s_line.Substring(s_pos + 1).Trim();
                                //Set pair name to selection name
                                pair.Name = s_selection.ToUpper();
                                //Set selection pair key
                                pair.Key = s_key;
                                //Add to the hash list
                                ht.Add(pair,s_val);
                            }
                        }
                    }
                    //Close file
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Update the input main config file.
        /// </summary>
        public void Update()
        {
            //Check that length of not zero
            if (m_config_file.Length == 0)
            {
                return;
            }
            //Save the config file.
            SaveIniFile(m_config_file);
        }

        /// <summary>
        /// Save the config data to a new filename
        /// </summary>
        /// <param name="Filename"></param>
        public void SaveIniFile(string Filename)
        {
            List<string> selections = new List<string>();
            string StrLine = string.Empty;

            try
            {
                //Open file for writing
                using (StreamWriter sw = new StreamWriter(Filename))
                {

                    foreach (TSelction_Pair pair in ht.Keys)
                    {
                        //Check if selection is in the list
                        if (!selections.Contains(pair.Name))
                        {
                            //Add it to the list
                            selections.Add(pair.Name);
                        }
                    }

                    foreach (string sel in selections)
                    {
                        //Line to save to file selection
                        StrLine += ("[" + sel + "]" + Environment.NewLine);

                        foreach (TSelction_Pair pair in ht.Keys)
                        {
                            //Check if pair selection name equals Selection
                            if (pair.Name.Equals(sel))
                            {
                                //Fetch value from hash table pair
                                string temp_value = (string)ht[pair];
                                //Check to see if the value is null
                                if (temp_value != null)
                                    temp_value = "=" + temp_value;
                                //Proper case the key name
                                string sKey = FixKeyName(pair.Key);
                                //Append key and value to StrLine
                                StrLine += (sKey + temp_value + Environment.NewLine);
                            }
                        }
                        //Append lash new line break
                        StrLine += Environment.NewLine;
                    }
                    //Save StrLine to file trim the excess spaces and append a new line.
                    sw.Write(StrLine.TrimEnd() + Environment.NewLine);
                    //Close file
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                //Raise error
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Return a list object of selection names
        /// </summary>
        public List<string> ReadSelections
        {
           
            get
            {
                List<string> sels = new List<string>();

                foreach (TSelction_Pair pair in ht.Keys)
                {
                    //Check if the selection name already exists in the list
                    if (!sels.Contains(pair.Name))
                    {
                        //Add to selections list
                        sels.Add(pair.Name);
                    }
                }
                return sels;
            }
        }

        /// <summary>
        /// Return true if a selection is found in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <returns></returns>
        public bool HasSelection(string Selection)
        {
            bool Found = false;

            foreach (TSelction_Pair pair in ht.Keys)
            {
                //Check if pair selection equals Selection string
                if (pair.Name.Equals(Selection, StringComparison.OrdinalIgnoreCase))
                {
                    //Set found to true
                    Found = true;
                    //Exit
                    break;
                }
            }
            //Return Found value
            return Found;
        }

        /// <summary>
        /// Return true if a key is found in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public bool HasKey(string Selection, string Key)
        {
            bool Found = false;
            
            foreach (TSelction_Pair pair in ht.Keys)
            {
                //Check that we are on the correct selection
                if (pair.Name.Equals(Selection, StringComparison.OrdinalIgnoreCase))
                {
                    //Check that the key is in the selection above
                    if (Key.Equals(pair.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        //Set found to true
                        Found = true;
                    }
                }
            }
            return Found;
        }

        public List<string> ReadKeys(string Selection)
        {
            List<string> _keys = new List<string>();

            if (Selection.Length == 0)
            {
                return _keys;
            }

            foreach (TSelction_Pair pair in ht.Keys)
            {
                // Check if pair selection name equals Selection string
                if (pair.Name.Equals(Selection, StringComparison.OrdinalIgnoreCase))
                {
                    //Add pair to hash table
                    _keys.Add(FixKeyName(pair.Key));
                }
            }
            //Return keys
            return _keys;
        }

        /// <summary>
        /// Read a string value from a config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public string ReadString(string Selection, string Key, string vDefault = "")
        {
            TSelction_Pair pair;
            string sVal = string.Empty;
            //Set pair selection name to uppercase
            pair.Name = Selection.ToUpper();
            //Set pair key to uppercase
            pair.Key = Key.ToUpper();

            try
            {
                //Fetch the object from the hash table
                sVal = (string)ht[pair];
                //Check if sVal is empty
                if (sVal.Equals(""))
                {
                    //Return default
                    return vDefault;
                }
                else
                {
                    return sVal;
                }
            }
            catch
            {
                //Return default
                return vDefault;
            }
        }

        /// <summary>
        /// Reads an integer value from the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public int ReadInteger(string Selection, string Key, int vDefault = 0)
        {
            string value = ReadString(Selection, Key, vDefault.ToString());
            return int.Parse(value);
        }

        /// <summary>
        /// Reads a long value from a config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public long ReadLong(string Selection, string Key, long vDefault = 0)
        {
            string value = ReadString(Selection, Key, vDefault.ToString());
            return long.Parse(value);
        }

        /// <summary>
        /// Read a double value from the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        
        public double ReadDouble(string Selection, string Key, double vDefault = 0.0)
        {
            string value = ReadString(Selection, Key, vDefault.ToString());
            return Double.Parse(value);
        }

        /// <summary>
        /// Returns a bool value from a config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public bool ReadBool(string Selection, string Key, bool vDefault = false)
        {
            string value = ReadString(Selection, Key, vDefault.ToString()).ToLower();
            bool bValue = vDefault;
            //Test for true value
            if (value == "true" || value == "on" || value == "yes" || value == "1")
            {
                bValue = true;
            } 
            //Test for false value
            else if (value == "false" || value == "off" || value == "no" || value == "0")
            {
                bValue = false;
            }
            else
            {
                bValue = vDefault;
            }

            return bValue;
        }
        /// <summary>
        /// Write or update a bool value to a config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteBool(string Selection, string Key, bool Value)
        {
            WriteString(Selection, Key, Value.ToString());
        }

        /// <summary>
        /// Write or update an existing key value in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteString(string Selection, string Key, string Value)
        {
            TSelction_Pair tmp;

            tmp.Name = Selection.ToUpper().Trim();
            tmp.Key = Key.ToUpper().Trim();

            if (tmp.Name.Length == 0)
            {
                throw new Exception("Selection name required.");
            }
            else if (tmp.Key.Length == 0)
            {
                throw new Exception("Selection found key expected.");
            }
            else
            {
                //Remove the old selection and key
                if (ht.Contains(tmp))
                {
                    ht.Remove(tmp);
                }
                //Add new obj
                ht.Add(tmp, Value);
            }
        }

        /// <summary>
        /// Write or update a string with line new line breaks
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteMultilineString(string Selection, string Key, string Value)
        {
            WriteString(Selection, Key, Value.Replace(Environment.NewLine, "\\n"));
        }

        /// <summary>
        /// Read in a string value with new line breaks
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public string ReadMultilineString(string Selection, String Key, String vDefault = "")
        {
            return ReadString(Selection, Key, vDefault).Replace("\\n", Environment.NewLine);
        }

        /// <summary>
        /// Write or update an existing integer value in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteInteger(string Selection, string Key, int Value)
        {
            WriteString(Selection, Key, Value.ToString());
        }

        /// <summary>
        /// Write or update an existing long value in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteLong(string Selection, string Key, long Value)
        {
            WriteString(Selection, Key, Value.ToString());
        }

        /// <summary>
        /// Write or update an existing double value in the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteDouble(string Selection, string Key, double Value)
        {
            WriteString(Selection, Key, Value.ToString());
        }

        /// <summary>
        /// Writes binary data passed as a Base64 string
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="Data"></param>
        public void WriteBinary(string Selection, string Key, byte[] Data)
        {
            try
            {
                //Write the bytes in Data to a b64 string
                WriteString(Selection, Key, Convert.ToBase64String(Data));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Reads in a Base64 string and returns the binary bytes.
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        /// <param name="vDefault"></param>
        /// <returns></returns>
        public byte[] ReadBinary(string Selection, string Key, string vDefault="")
        {
            string b_64 = ReadString(Selection, Key, vDefault);
            byte[] _bytes = { 0 };

            try
            {
                //Get bytes from b64 string
                _bytes = Convert.FromBase64String(b_64);
                //Return bytes
                return _bytes;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Remove a key and it's value from the config file
        /// </summary>
        /// <param name="Selection"></param>
        /// <param name="Key"></param>
        public void RemoveKey(string Selection, string Key)
        {
            TSelction_Pair pair = new TSelction_Pair();
            //Set the data to find
            pair.Name = Selection.ToUpper();
            pair.Key = Key.ToUpper();

            //Check if pair is in hash table
            if (ht.ContainsKey(pair))
            {
                //Remove from hash table
                ht.Remove(pair);
            }

        }

        /// <summary>
        /// Removes a selection and all it's keys and values
        /// </summary>
        /// <param name="Selection"></param>
        public void RemoveSelection(string Selection)
        {
            List<TSelction_Pair> paris = new List<TSelction_Pair>();

            foreach (TSelction_Pair p in ht.Keys)
            {
                TSelction_Pair n_pair = p;
                //Check if n_pair selection name is equal Selection string
                if (n_pair.Name.Equals(Selection, StringComparison.OrdinalIgnoreCase))
                {
                    //Add pair to list
                    paris.Add(n_pair);
                }
            }
            //Check count of list
            if (paris.Count > 0)
            {
                foreach (TSelction_Pair pp in paris)
                {
                    //Remove the obj from the hash table
                    ht.Remove(pp);
                }
            }
            paris = new List<TSelction_Pair>();
        }
    }
}
