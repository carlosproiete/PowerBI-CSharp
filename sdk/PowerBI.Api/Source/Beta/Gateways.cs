// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Beta
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// Gateways operations.
    /// </summary>
    public partial class Gateways : IServiceOperations<PowerBIClient>, IGateways
    {
        /// <summary>
        /// Initializes a new instance of the Gateways class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public Gateways(PowerBIClient client)
        {
            if (client == null) 
            {
                throw new ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the PowerBIClient
        /// </summary>
        public PowerBIClient Client { get; private set; }

        /// <param name='collectionName'>
        /// The workspace collection name
        /// </param>
        /// <param name='workspaceId'>
        /// The workspace id
        /// </param>
        /// <param name='gatewayId'>
        /// </param>
        /// <param name='datasourceId'>
        /// </param>
        /// <param name='datasourceDelta'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<object>> PatchDatasourceWithHttpMessagesAsync(string collectionName, string workspaceId, string gatewayId, string datasourceId, object datasourceDelta, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (collectionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "collectionName");
            }
            if (workspaceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "workspaceId");
            }
            if (gatewayId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "gatewayId");
            }
            if (datasourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "datasourceId");
            }
            if (datasourceDelta == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "datasourceDelta");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("collectionName", collectionName);
                tracingParameters.Add("workspaceId", workspaceId);
                tracingParameters.Add("gatewayId", gatewayId);
                tracingParameters.Add("datasourceId", datasourceId);
                tracingParameters.Add("datasourceDelta", datasourceDelta);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "PatchDatasource", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new Uri(new Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "beta/collections/{collectionName}/workspaces/{workspaceId}/gateways/{gatewayId}/datasources/{datasourceId}").ToString();
            _url = _url.Replace("{collectionName}", Uri.EscapeDataString(collectionName));
            _url = _url.Replace("{workspaceId}", Uri.EscapeDataString(workspaceId));
            _url = _url.Replace("{gatewayId}", Uri.EscapeDataString(gatewayId));
            _url = _url.Replace("{datasourceId}", Uri.EscapeDataString(datasourceId));
            // Create HTTP transport objects
            HttpRequestMessage _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("PATCH");
            _httpRequest.RequestUri = new Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            _requestContent = SafeJsonConvert.SerializeObject(datasourceDelta, this.Client.SerializationSettings);
            _httpRequest.Content = new StringContent(_requestContent, Encoding.UTF8);
            _httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            // Set Credentials
            if (this.Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<object>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = SafeJsonConvert.DeserializeObject<object>(_responseContent, this.Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
