namespace movielandia_.net_api.DTOs.Responses
{
    public class ErrorResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
        public Dictionary<string, string[]> Errors { get; set; }

        public ErrorResponse(string type, string title, int status)
        {
            Type = type;
            Title = title;
            Status = status;
            Errors = new Dictionary<string, string[]>();
            TraceId = Guid.NewGuid().ToString();
        }

        public void AddError(string key, string error)
        {
            if (!Errors.ContainsKey(key))
            {
                Errors[key] = new[] { error };
            }
            else
            {
                var errors = Errors[key].ToList();
                errors.Add(error);
                Errors[key] = errors.ToArray();
            }
        }
    }
}
