namespace ConsoleApp3
{
    public static class ProcessDataFromApi
    {
        public static async Task WaitForAny()
        {
            var dataFromMethod1 = FetchDataFromAPI1();
            var dataFromMethod2 = FetchDataFromAPI2();
            _ = await Task.WhenAny(dataFromMethod1, dataFromMethod2);
        }
        public static async Task WaitForAll()
        {
            var dataFromMethod1 = FetchDataFromAPI1();
            var dataFromMethod2 = FetchDataFromAPI2();
            _ = await Task.WhenAll(dataFromMethod1, dataFromMethod2);
        }

        public static async Task<string> FetchDataFromAPI1()
        {
            return await Task.FromResult("teste 1");
        }
        public static async Task<string> FetchDataFromAPI2()
        {
            return await Task.FromResult("teste 2");
        }
    }
}
