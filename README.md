# ServiceThrottlingDemo

Project Article: https://portfolio.katiegirl.net/2019/11/19/service-throttling-in-wcf-services-a-demo-of-service-concurrency-and-instance-throttling-behaviors-with-multi-threading-clients/



Service Throttling in WCF Services – A Demo of Service Concurrency and Instance Throttling Behaviors with Multi-threading Clients


This project presents a simple Demo WCF Service and “Tester” Client Application demonstration that implements concurrency and instancing behaviors on a service with multiple client thread calls to a method on the service. The project also demos throttling service behaviors that are in the service configuration settings. Service throttling limits the client calls that could otherwise drain or slow down its service to other clients if too many are calling simultaneously. The Demo Service is a standard template WCF service application hosted by the development IIS. The service features one simple method… a test method that simulates a long running process (it sleeps for 5 seconds). The client “tester” is a simple console application that creates multiple threads that access the service and report back on the results. The objective of this project was not to demo setup and hosting of a service, nor the client interface, but retrieve and display results of service behaviors with respect to multi-threaded access. Discussion regarding the hosting and setup of the simple IIS hosted service application will be skipped in this project article. 


The demo project consists of these simple component topics:


•	WCF Service (Hosted by IIS) Application Project “ServiceThrottlingDemo”

o	ITestService – Interface of Service and Operational Contracts
o	TestService – Implements the Service Interface


o	Web.config (Configuration for Service Hosted on IIS Express)

•	Client “Tester to Service” Windows Console Application “MultiThreadClientTester”
o	Service Reference Proxy (WSDL) to WCF Service
o	Program – Creates multiple threads that call the service, records time spent in threads, and reports statistics on the final results in a console window. 
