# Tutorial_PocketBook

This project follows up this tutorial:
https://www.youtube.com/watch?v=-jcf1Qq8A-4&t=3s

It´s a basic project that using a single model named User implements helps to implement and practice:

1-Entity Framework Core with Code First
2-Web API
3-Repository pattern
4-Unit of work pattern

ENDPOINTS 

--Http POST => /uSersController  
Creates a new User

Request Body
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "firstName": "string",
  "lastName": "string",
  "email": "string"
}

--Http GET UsersConstroller
Brings all Users

--Http GET /UsersController/{id}

id must be a Guid, brings a single user information

--Http DELETE /UsersController/{id}
Just for learning porpuses just returns true or false but does not delete

