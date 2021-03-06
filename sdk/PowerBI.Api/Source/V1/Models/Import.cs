// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V1;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The import object
    /// </summary>
    public partial class Import
    {
        /// <summary>
        /// Initializes a new instance of the Import class.
        /// </summary>
        public Import()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Import class.
        /// </summary>
        /// <param name="id">The import id</param>
        /// <param name="name">The import name name</param>
        /// <param name="importState">The import upload state</param>
        /// <param name="reports">The reports associated with this
        /// import</param>
        /// <param name="datasets">The datasets associated with this
        /// import</param>
        /// <param name="createdDateTime">Import creation time</param>
        /// <param name="updatedDateTime">Import last update time</param>
        public Import(string id = default(string), string name = default(string), string importState = default(string), IList<Report> reports = default(IList<Report>), IList<Dataset> datasets = default(IList<Dataset>), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? updatedDateTime = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            ImportState = importState;
            Reports = reports;
            Datasets = datasets;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the import id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the import name name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the import upload state
        /// </summary>
        [JsonProperty(PropertyName = "importState")]
        public string ImportState { get; set; }

        /// <summary>
        /// Gets or sets the reports associated with this import
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<Report> Reports { get; set; }

        /// <summary>
        /// Gets or sets the datasets associated with this import
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<Dataset> Datasets { get; set; }

        /// <summary>
        /// Gets or sets import creation time
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets import last update time
        /// </summary>
        [JsonProperty(PropertyName = "updatedDateTime")]
        public System.DateTime? UpdatedDateTime { get; set; }

    }
}
