# Bible Category API

## Create Bible Category

### Create Bible Category Request

```js
POST /bibles/categories
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "CategoryName": "string",
    "CategoryDescription": "string"
}
```

### Create Bible Category Response

```javascript
201 Created 
```

```javascript
Location: {{host}}/bibles/categories/{{id}}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "CategoryName": "string",
    "CategoryDescription": "string"
}
```

## Get Bible Category

### Get Bible Category Request

```javascript
GET /bible/category/{{id}}
```

### Get Bible Category Repsonse

```javascript
200 Ok 
```

```javascript
Location: {{host}}/bible/category/{{id}}
```

or

```javascript
404 Not Found
```

## Update Bible Category

### Update Bible Category Request

```javascript
PUT /bible/category/{{id}}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "CategoryName": "string",
    "CategoryDescription": "string"
}
```

### Update Bible Category Response

```javascript
204 No Content
```

or

```javascript
201 Created
```

```javascript
Location: {{host}}//{{id}}
```

## Delete Bible Category

### Delete Bible Category Request

```javascript
DELETE /bible/category/{{id}}
```

### Delete Bbile Category Response

```javascript
204 No Content
```

or

```javascript
404 Not Found
```