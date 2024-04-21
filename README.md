# User and Order Management API

This repository contains a simple Web API written in Microsoft .Net Core and Entity Framework for managing users and orders, with support for pagination.

## Installation and Usage

### Installation

To build the project, use the following command:

````sh
dotnet build

### Usage

To run the project, use the following command:

```sh
dotnet run

## API Endpoints
- **GET Users:** Retrieve a list of users.
  Endpoint: localhost:5143/api/user
- **GET Orders:** Retrieve a list of orders.
  Endpoint: localhost:5143/api/order
- **GET Users with Pagination:** Retrieve a paginated list of users.
  Endpoint: localhost:5143/api/user?pageNumber=1&pageSize=10
- **Create User:** Create a new user.
  Endpoint: POST localhost:5143/api/user
- **Update User:** Update an existing user.
  Endpoint: PUT localhost:5143/api/user/{id}
- **Delete User:** Delete an existing user.
  Endpoint: DELETE localhost:5143/api/user/{id}
- **Create Order:** Create a new order.
  Endpoint: POST localhost:5143/api/order
- **Update Order:** Update an existing order.
  Endpoint: PUT localhost:5143/api/order/{id}
- **Delete Order:** Delete an existing order.
  Endpoint: DELETE localhost:5143/api/order/{id}

## Sample Response of GET Users

```sh
[
    {
        "id": 1,
        "firstName": "John",
        "lastName": "Doe",
        "email": "johndoe@gmail.com",
        "createdAt": "2024-04-18T03:34:31.930111Z",
        "orders": [
            {
                "id": 1,
                "orderNumber": "0001",
                "userId": 1
            },
            {
                "id": 2,
                "orderNumber": "0002",
                "userId": 1
            }
        ]
    },
    {
        "id": 2,
        "firstName": "Alex",
        "lastName": "Jackson",
        "email": "alex@gmail.com",
        "createdAt": "2024-04-18T03:35:19.976002Z",
        "orders": []
    }
]
````
