namespace pattern_facade
{
    public class NotificationServer
    {
        // connect --> Connection
        // authenticate --> (appId, key) --> AuthToken
        // send --> (authToken, message, target)
        // disconnect

        public Connection Connect(string ipAddress) {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key) {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target) {
            System.Console.WriteLine("Sending a message.");
        }

        
    }
}