# UploadLargeFiles.Net5.Api
This API is designed to support large file uploads.
<br>

It includes specific configurations to increase upload limits, enabling efficient transfer of large files without excessive restrictions. However, many solutions that involve simply removing limits in APIs are not secure and can jeopardize system security and stability. It is important to carefully evaluate these decisions and implement appropriate security measures. <br>
This API is built with .NET 5. It is crucial to keep in mind that, even if we increase the limits in the API, if it runs inside a Docker container, we will likely need to manage Docker's own limits to prevent restrictions on the uploads.

### 📄API Reference
#### Endpoint

```http
POST /File
```

#### 🚀Run script with dotnet

```bash
  dotnet run
```

#### Result

```bash
  http://localhost:5213/swagger/index.html
```

📙 My article in medium: https://medium.com/@agustinafassina_92108/upload-large-files-with-net-8-872d002673a0
