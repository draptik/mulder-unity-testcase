namespace MyApp.ViewModel.Response
{
    public class DefaultResponse
    {
        protected DefaultResponse()
        {
            Success = true;
        }

        public bool Success { get; set; }
    }
}