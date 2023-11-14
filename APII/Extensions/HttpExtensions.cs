using System.Text.Json;
using System.Text.Json.Nodes;
using APII.Helpers;
using Microsoft.AspNetCore.Http.Json;

namespace APII.Extensions

{
public static class HttpExtensions{

public static void AddPaginationHeader(this HttpResponse response, PaginationHeader header){

var jsonOptions = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};

response.Headers.Add("Pagination" , JsonSerializer.Serialize(header, jsonOptions));

response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
}
}
}