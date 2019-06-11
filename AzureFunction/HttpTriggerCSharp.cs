using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    struct EanGuidJson{
        public string ean       ;
        public string eanguid   ;
    }
    class GuidGenerator{
        public Guid[] GuidBuilder(String[] ean){
            Guid[] g = new Guid[ean.Length];
            for(int i = 0; i < ean.Length; i += 1){
                g[i] = Guid.NewGuid();
            }
            return g;
        }
    }
    public static class HttpTriggerCSharp
    {
        [FunctionName("HttpTriggerCSharp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            
            if(req.Method == "POST"){

                string[] prodid;
                string retstr;
                // request in
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                int? reqblen = requestBody.Length;
                Console.WriteLine(reqblen);
                // Check if string is 0 length
                Console.WriteLine("Request body length: {0}", (reqblen == 0 ? "0" : reqblen.ToString()));
                if(reqblen == 0){
                    // Here we use Query params
                    prodid = req.Query["prodid"];
                    retstr = JsonConvert.SerializeObject(prodid);

                    return prodid != null
                        ? (ActionResult)new OkObjectResult(retstr)
                        : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
                }else{
                    dynamic data = JsonConvert.DeserializeObject(requestBody);
                    Console.WriteLine("Write data['prodid']: {0}", (data["prodid"] == null ? "null" : data["prodid"]));
                    Console.WriteLine("Write data length: {0}", (data["prodid"] == null ? "null": data["prodid"].Count));
                    //Console.WriteLine(data.Length);
                    if(data["prodid"].Count == 0){
                        // use Query
                        prodid = req.Query["prodid"];
                        Console.WriteLine("Prodid count = 0");
                    }else{
                        prodid = new string[data["prodid"].Count];
                        //prodid = prodid ?? data?.prodid;
                        int counter = 0;
                        foreach(string p in data["prodid"]){
                            prodid[counter] = p;
                            counter += 1;
                        }
                    }

                    var guidgen    = new GuidGenerator()        ;
                    string[] eans  = new string[prodid.Length]  ;
                    eans           = prodid                     ;
                    Guid[] retguid = guidgen.GuidBuilder(eans)  ;



                    var egja = new EanGuidJson[prodid.Length];
                    
                    for(int i = 0; i < eans.Length; i++){
                        Guid g = retguid[i];
                        var retj = new EanGuidJson{
                            ean     = prodid[i],
                            eanguid = g.ToString()
                        };

                        egja[i] = retj;
                    }

                    retstr = JsonConvert.SerializeObject(egja);

                    return prodid != null
                        ? (ActionResult)new OkObjectResult(retstr)
                        : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
                }
            }//END POST
            string[] prodid1 = {"Outside my scope"};
            string retstr1 = prodid1[0];
            return prodid1 != null
                    ? (ActionResult)new OkObjectResult(retstr1)
                    : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
