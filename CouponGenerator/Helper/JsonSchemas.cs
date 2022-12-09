using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using NJsonSchema.Generation;
using NJsonSchema;
using NJsonSchema.Yaml;

namespace CouponGenerator
{
    /// <summary>
    /// JSON Schema
    /// </summary>
    public static class JsonSchemas
    {
        /// <summary>
        /// 生成JSON Schema文档
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="jsonSchemaOutputFormatter">JSON Schema文档输出格式</param>
        /// <param name="jsonSerializerSettings">JSON序列号设置</param>
        /// <returns></returns>
        public static string GenerateJsonSchema<T>(JsonSchemaOutputFormatter jsonSchemaOutputFormatter,
            JsonSerializerSettings? jsonSerializerSettings = null) where T : class
        {
            jsonSerializerSettings ??= new JsonSerializerSettings()
            {
                ContractResolver = null
            };
            string output = string.Empty;
            JsonSchema schema = JsonSchema.FromType<T>(new JsonSchemaGeneratorSettings()
            {
                SerializerSettings = jsonSerializerSettings
            });
            if (jsonSchemaOutputFormatter == JsonSchemaOutputFormatter.JSON)
            {
                output = schema.ToJson();
            }
            else if (jsonSchemaOutputFormatter == JsonSchemaOutputFormatter.YAML)
            {
                output = schema.ToYaml();
            }
            return output;
        }
    }

    /// <summary>
    /// JSON Schema文档输出格式
    /// </summary>
    public enum JsonSchemaOutputFormatter
    {
        /// <summary>
        /// Json格式
        /// </summary>
        JSON,
        /// <summary>
        /// Yaml格式
        /// </summary>
        YAML
    }
}
