﻿using Domain.Entidade.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialWeb.Controllers
{
    public abstract class BaseController : Controller
    {
        protected BaseController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;

        }
        public IConfiguration _configuration { get; }

        public HttpClient _httpClient;

        public async Task<TokenCode> ApiToken(Object objeto)
        {
            var json = JsonConvert.SerializeObject(objeto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resultado = await _httpClient.PostAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/JwtAutenticacao", content);
            if (resultado.IsSuccessStatusCode)
            {
                var conteudo = await resultado.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<TokenCode>(conteudo);
                return token;
            }

            return new TokenCode();
        }

        public async Task<List<TipoRetorno>> ApiFind<TipoRetorno>(string jwt, string path)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var reponse = await _httpClient.GetAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}");
            var conteudo = await reponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<TipoRetorno>>(conteudo);
        }

        public async Task<List<TipoRetorno>> ApiFindAllById<TipoRetorno>(string jwt, Object id, string path)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var reponse = await _httpClient.GetAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}/{id}");
            var conteudo = await reponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<TipoRetorno>>(conteudo);
        }


        public async Task<TipoRetorno> ApiFindById<TipoRetorno>(string jwt, Object id, string path)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var reponse = await _httpClient.GetAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}/{id}");
            var conteudo = await reponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TipoRetorno>(conteudo);
        }

        public async Task<TipoRetorno> ApiSaveAutorize<TipoRetorno>(string jwt, Object objeto, string path)
        {
            var json = JsonConvert.SerializeObject(objeto);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resultado = await _httpClient.PostAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}", content);
            var conteudo = await resultado.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TipoRetorno>(conteudo);
        }
        public async Task<HttpResponseMessage> ApiSave(Object objeto, string path)
        {
            var json = JsonConvert.SerializeObject(objeto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resultado = await _httpClient.PostAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}", content);
            return resultado;
        }

        public async Task<HttpResponseMessage> ApiRemove(string jwt, Object id, string path)
        {
            var json = JsonConvert.SerializeObject(id);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resultado = await _httpClient.DeleteAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}/{id}");
            return resultado;
        }

        public async Task<TipoRetorno> ApiUpdate<TipoRetorno>(string jwt, Object id, Object objeto, string path)
        {
            var json = JsonConvert.SerializeObject(objeto);
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", jwt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var resultado = await _httpClient.PutAsync($"{_configuration.GetSection("Logging").GetSection("ConnectionStrings")["ConnectionStringsApi"]}/api/{path}/{id}", content);
            var conteudo = await resultado.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TipoRetorno>(conteudo);
        }

    }
}
