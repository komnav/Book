# Books.API

## Overview
Books.API is a simple API for managing books, authors, and categories. It allows you to create, retrieve, update, and delete books. This API is designed to help manage book information in a structured manner.

## API Specification
The API is documented using the OpenAPI 3.0.1 specification.

### Base URL
The base URL for the API is /api.

## Endpoints

### Books

#### POST /Books
Create a new book.

- Tags: Books
- Request Body:
  - Content Types: application/json, text/json, application/*+json
  - Schema: [Book](#book)
- Responses:
  - 200: Success

#### GET /Books
Retrieve all books.

- Tags: Books
- Responses:
  - 200: Success

#### GET /Books/{id}
Retrieve a book by its ID.

- Tags: Books
- Parameters:
  - Path Parameters:
    - id (integer, required): The ID of the book.
- Responses:
  - 200: Success

#### DELETE /Books/{id}
Delete a book by its ID.

- Tags: Books
- Parameters:
  - Path Parameters:
    - id (integer, required): The ID of the book.
- Responses:
  - 200: Success

#### PUT /Books/{id}
Update a book by its ID.

- Tags: Books
- Parameters:
  - Path Parameters:
    - id (integer, required): The ID of the book.
- Request Body:
  - Content Types: application/json, text/json, application/*+json
  - Schema: [Book](#book)
- Responses:
  - 200: Success

## Models

### Book

```json
{
  "type": "object",
  "properties": {
    "id": {
      "type": "integer",
      "format": "int32"
    },
    "authors": {
      "type": "string",
      "nullable": true
    },
    "title": {
      "type": "string",
      "nullable": true
    },
    "price": {
      "type": "number",
      "format": "double"
    },
    "image": {
      "type": "string",
      "format": "byte",
      "nullable": true
    },
    "category": {
      "$ref": "#/components/schemas/Category"
    },
    "categoryId": {
      "type": "integer",
      "format": "int32",
      "nullable": true
    },
    "author": {
      "$ref": "#/components/schemas/Author"
    },
    "authorId": {
      "type": "integer",
      "format": "int32",
      "nullable": true
    }
  },
  "additionalProperties": false
}
