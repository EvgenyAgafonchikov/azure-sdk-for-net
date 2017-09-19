// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Search.EntitySearch.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Search;
    using Microsoft.CognitiveServices.Search.EntitySearch;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a contractual rule for link attribution.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ContractualRules/LinkAttribution")]
    public partial class ContractualRulesLinkAttribution : ContractualRulesAttribution
    {
        /// <summary>
        /// Initializes a new instance of the ContractualRulesLinkAttribution
        /// class.
        /// </summary>
        public ContractualRulesLinkAttribution()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContractualRulesLinkAttribution
        /// class.
        /// </summary>
        /// <param name="targetPropertyName">The name of the field that the
        /// rule applies to.</param>
        /// <param name="mustBeCloseToContent">A Boolean value that determines
        /// whether the contents of the rule must be placed in close proximity
        /// to the field that the rule applies to. If true, the contents must
        /// be placed in close proximity. If false, or this field does not
        /// exist, the contents may be placed at the caller's
        /// discretion.</param>
        /// <param name="text">The attribution text.</param>
        /// <param name="url">The URL to the provider's website. Use text and
        /// URL to create the hyperlink.</param>
        /// <param name="optionalForListDisplay">Indicates whether this
        /// provider's attribution is optional.</param>
        public ContractualRulesLinkAttribution(string targetPropertyName = default(string), bool? mustBeCloseToContent = default(bool?), string text = default(string), string url = default(string), bool? optionalForListDisplay = default(bool?))
            : base(targetPropertyName, mustBeCloseToContent)
        {
            Text = text;
            Url = url;
            OptionalForListDisplay = optionalForListDisplay;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the attribution text.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the URL to the provider's website. Use text and URL to
        /// create the hyperlink.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets indicates whether this provider's attribution is optional.
        /// </summary>
        [JsonProperty(PropertyName = "optionalForListDisplay")]
        public bool? OptionalForListDisplay { get; private set; }

    }
}
