# Create Bible Feature API

## Request

```js
POST /bibles/features
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "FeatureName": "Feature",
}
```

## Response

```javascript
201 Created 
```

```javascript
Location: {{host}}/bibles/features/{{id}}
```

```json
{
    "Id": "00000000-0000-0000-0000-000000000000",
    "FeatureName": "Feature",
    "FeatureDescription": "Description"
}
```
