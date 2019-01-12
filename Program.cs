using System;
using MailRuCloudApi;
using System.IO;
using System.ComponentModel;

namespace ConsoleApplication1
{
    class Program
    {
        static private Account account;

        static void Main(string[] args)
        {
            Console.WriteLine(args.Length.ToString());

            if (args.Length != 4)
            {
                return;
            }

            var fileName = args[0];
            var destinationPath = args[1];
            var login = args[2];
            var password = args[3];

            account  = new Account(login, password);

            var api = new MailRuCloud() { Account = account };

            //var percent = 0;
            api.ChangingProgressEvent += delegate (object sender, ProgressChangedEventArgs e)
            {
                //percent = e.ProgressPercentage
                Console.WriteLine("uploading "+e.ProgressPercentage);
            };

            api.UploadFile(new FileInfo(fileName), destinationPath).Wait();

            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(Convert.ToDouble(-45));

            Entry items = api.GetItems(destinationPath).Result;
            foreach (MailRuCloudApi.File f in items.Files)
            {
                if (f.LastModifiedTimeUTC<answer)
                {
                    api.Remove(f.FulPath).Wait();
                }
            }

            api = null;

        }
    }
}
