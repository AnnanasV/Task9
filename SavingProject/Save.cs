namespace SavingProject
{
    public class Save
    {
        public async Task DownloadDataAsync(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string data = await client.GetStringAsync(url);
                    await File.WriteAllTextAsync(filePath, data);
                }
                catch (Exception ex)
                {
                    await Console.Out.WriteLineAsync(ex.Message);
                }
            }
            await Console.Out.WriteLineAsync("end");
        }
    }
}