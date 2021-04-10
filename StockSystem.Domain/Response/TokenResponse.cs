namespace StockSystem.Domain.Response
{
    public class TokenResponse
    {
        public TokenResponse(string token, double expiresIn)
        {
            Token = token;
            ExpiresIn = expiresIn;
        }

        public string Token { get; private set; }
        public double ExpiresIn { get; private set; }
    }
}
