## Grocery Management Application


This application involves
~~~~~~~~~~~~~~~~~~~~~~~~~~

1. Mobile client - Xamarin Forms
2. Backend API - .Net Core 2.0 web api
3. API hosted on - Azure cloud API app
4. Database - Azure Cosmos db - DocumentDB API (No sql database)
~~~~~~~~~~~~~~~~~~~~~~~~~~~

Features used in Xamarin Form Mobile client App 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1. Master detail page navigation
2. Web api hosted on Azure cloud communication
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


Features used in .Net Core Web API 2.0 Application
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
1. Communication to Azure cosmos db - document db api database
2. Layered architecture design.

​```flow
st=>start: Start
op=>operation: APIRequest to Controllers (e.g. update Grocery)
op=>operation: GroceryService (Grocery Specific)	
op=>operation: DBCommunicator<T> (Generic) - communicate to cosmos db
e=>end: End
​```
	



~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


