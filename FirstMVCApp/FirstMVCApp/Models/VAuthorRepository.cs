using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FirstMVCApp.Models
{
    public class VAuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"c:/temp/Author.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExist = System.IO.File.Exists(fName);
            if (isFileExist)
            {
                using (StreamReader sr = new StreamReader(fName, true))
                {
                    // sr.BaseStream.Position = 0;
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(",");
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.Authorid, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = sr.ReadLine();
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.Authorid, author);
                            }
                        }


                    }
                }

            }
            return list;
        }
        public static Author StringToAuthor(String[] data, Author author)
        {
            author.Authorid = int.Parse(data[0]);
            author.Name = data[1];
            author.DateOfBirth = DateTime.Parse(data[2]);
            author.NoOfBooks = int.Parse(data[3]);
            author.Royalty = data[4];
            return author;


        }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"c:/temp/Author.txt";
            string strAuthor = $"{pAuthor.Authorid},{pAuthor.Name},{pAuthor.DateOfBirth},{pAuthor.NoOfBooks},{pAuthor.Royalty}";
            using (StreamWriter sw = new StreamWriter(fName,true))
            {
                sw.WriteLine(strAuthor);
            }

        }
        public static Author FindAuthorId(int id)
        {
            Dictionary<int, Author> list = VAuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {

                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            string fName = @"c:/temp/Author.txt";
            Dictionary<int, Author> list = VAuthorRepository.GetAuthorDictionary();
            string strAuthor = string.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.Authorid != pAuthor.Authorid)
                    {
                        strAuthor = $"{author.Authorid},{author.Name},{author.DateOfBirth},{author.NoOfBooks},{author.Royalty}";
                    }
                    else
                    {
                        strAuthor = $"{pAuthor.Authorid},{pAuthor.Name},{pAuthor.DateOfBirth},{pAuthor.NoOfBooks},{pAuthor.Royalty}";
                    }
                    sw.WriteLine(strAuthor);



                }
            }

        }
        public static void RemoveAuthor(int id)
        {
            string fName = @"c:/temp/Author.txt";
            Dictionary<int, Author> list = VAuthorRepository.GetAuthorDictionary();
            StringBuilder sb = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.Authorid != id)
                {
                    sb.Append($"{author.Authorid},{author.Name},{author.DateOfBirth},{author.NoOfBooks},{author.Royalty}");
                }
                System.IO.File.WriteAllText(fName, sb.ToString());  
            }
       
        }
    }
}

   


      
           
//            public static List<Author> GetAuthorList()
//            {
//                return new List<Author>();
//            }
           
//            public static void RemoveAuthor(int id)
//            {

//            }
//            public static void Save(int id) { }
//        }
//    }
//}

