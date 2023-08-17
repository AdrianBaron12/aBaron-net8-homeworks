using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using week9HW;

 void MethodJSON() {

    Product product = new Product
    {
        ProductName = "Notebook",
        ProductPrice = 10
    };

    var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new KebabCaseNamingStrategy()  //4 : Version 10.0.1 : KebabCaseNamingStrategy not working
                                                            //5 : Version 13.0.1 : Now working again
                                                            //6 : Uninstalled : Not working anything and working after updated NuGet
        }
    });
    Console.WriteLine(json);
}


