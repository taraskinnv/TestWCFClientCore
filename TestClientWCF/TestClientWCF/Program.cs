using System;
using System.ServiceModel;

namespace TestClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("test");

                var myBinding = new BasicHttpBinding();
                var myEndpoint = new EndpointAddress("http://tservice.expobank.org:11443/IntegrationService.svc"); //Fill your service url here
                var myChannelFactory = new ChannelFactory<IntegrationServices>(myBinding, myEndpoint);
                IntegrationServices client = myChannelFactory.CreateChannel();

                Console.WriteLine("test1");
                var s = client.GetEDocumentVersionList(134028);

                Console.WriteLine("test2");
                Console.WriteLine(client.GetEntity("РАБ", "103538", "WS").ToString());


                ((ICommunicationObject)client).Close();
                //BasicHttpBinding Binding = new BasicHttpBinding();
                //WSHttpBinding binding = new WSHttpBinding();

                //var someServiceChannelFactory = new ChannelFactory<IntegrationServices>("AnonimousHttpIntegration");
                //Console.WriteLine(someServiceChannelFactory.Endpoint.Address);
                //Console.WriteLine(someServiceChannelFactory.Endpoint.Contract.Name);
                //var i = someServiceChannelFactory.CreateChannel();
                Console.WriteLine("test3");
                //Console.WriteLine(i.GetEDocumentVersionList(134028).ToString());
                //Console.WriteLine(i.GetEntity("РАБ", "103538", "WS").ToString());
                
                /*"AnonimousHttpIntegration"*/
               // IntegrationServicesClient client = new IntegrationServicesClient();
                //Console.WriteLine(client.Endpoint.Address);
                //Console.WriteLine("test1");
                //Console.WriteLine(client.GetEDocumentVersionList(134028));
                //Console.WriteLine(client.GetEntity("РАБ", "103538", "WS").ToString());
                //Console.WriteLine("test2");



            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(e.Message);
                //Console.ReadKey();
                //throw;
            }




            //IntegrationServicesClient client = new IntegrationServicesClient(ConfigurationManager.AppSettings[]);

        }
    }
}
