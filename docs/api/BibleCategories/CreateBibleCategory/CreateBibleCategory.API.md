# Create Bible Category API

## Request

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

## Response

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