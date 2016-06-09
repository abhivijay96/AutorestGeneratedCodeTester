# AutorestGeneratedCodeTester
This is a tool which generates code to test the code generated by Autorest for microservices.
It has a proxy which can be accessed at http://localhost:9000/ which records all the request made to the microservice.

The proxy can be accessed using docker as shown below : 

<code>$ docker -e base=http://uri:port/to/service/to/test -p 9000:9000 <your-docker-image></code>

The proxy can also be launched without using docker , by making the following changes in program.cs :
 
 Change : <code> string[] arr2 = {"http://localhost:9000/", Environment.GetEnvironmentVariable("base")}; </code>
 
 to
 
 <code>string[] arr2 = {"http://localhost:9000/", "http://uri:port/to/service/to/test"};</code>
 
 In both the cases, the generated code can be accessed using :
 
 <code>$ curl http://localhost:5000/generate/csharp > MyTests.cs</code>
 
 Example generated code and the swagger file corresponding to it has been put up in the same repository.
