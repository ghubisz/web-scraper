using System;
using System.Net;

class WebScraper
{
    static void Main()
    {
        Console.WriteLine("Enter the URL of the website to scrape:");
        string url = Console.ReadLine();

        try
        {
            //Create a WebClient instance to download the web page
            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            //TODO: Implement your scraping logic here
            //You can use libraries like HtmlAgilityPack or regex for parsing the HTML

            Console.WriteLine("Web scraping completed successfully!");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("An error occured: "+ ex.Massage);
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
