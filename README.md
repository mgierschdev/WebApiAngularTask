# WebApi (.Net6) and a Angular CRUD 
The following project contains: 

- A <b>Frontend</b> (Client side) Angular CRUD sample app
    - The front end contains a Angular Material Grid (Grid overview) which at the same time contains child Table components and Dialog components to display the API data.
    - The validations of the FrontEnd fields were done according to the Angular Form Validator specification.  
- A <b>Backend</b> (Server side) .Net 6.0  API endpoints for the CRUD
    - The Backend was developed according to the [<b>D</b>omain <b>D</b>riven <b>D</b>esign](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice)(DDD) microsoft specification. There are three projects-libraries API / Domain / Infrastructure, inside the UserBackend folder, each one with the corresponding responsability.
    - The API depends on the Domain and the Infrastructure, the Infrastructure on the Domain, the Domain does not depend on any and contains all the buss logic and validations.
    - The validation of the backend fields was done using the [fluent validation sintax](https://docs.fluentvalidation.net/en/latest/).
- A Docker composer composer file to orchestrate both services with a single command, each service contains it's own Dockerfile to start the service.

### <b>To start with Docker</b>:
`docker compose up`
* Frontend - URL: http://localhost:4200

#### To start without docker:
* Inside the front end folder `ng serve`
* Inside the UserBackend/API folder `dotnet run`

## API Endpoints 

* [GET] Get All posts
* [GET] Get All users
* [GET] Get User Posts
* [POST] Create User
* [DELETE] Delete User
* [POST] Update User

### To test the backend with swagger:
* URL: https://localhost:7066/swagger/index.html

1. Example create user request:
```
{
  "firstName": "First name",
  "lastName": "Second Name",
  "email": "email_address@gmail.com",
  "phoneNumber": "+5412345678"
}
```
2.  Example update user request:
```
{
  "id" : 1,
  "firstName": "Update name",
  "lastName": "Update last name",
  "email": "email_address@gmail.com",
  "phoneNumber": "+5412345678"
}
```

3. Example delete user request:
```
{
  "id": 1,
  "firstName": "string",
  "lastName": "string",
  "email": "email_address@gmail.com",
  "phoneNumber": "+5412345678"
}
```