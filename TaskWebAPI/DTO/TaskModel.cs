using Newtonsoft.Json;

namespace TaskWebAPI.DTO
{
    public class TaskModel
    {
        [JsonProperty(PropertyName = "taskName", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        [JsonProperty(PropertyName = "taskDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskDescription { get; set; }
    }
}
