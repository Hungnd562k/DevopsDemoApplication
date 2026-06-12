namespace WebApplication1.Model;

public class ConfigOptions
{
    public Logging Logging { get; set; }
    public string AllowedHosts { get; set; }
    public string AppUrl { get; set; }
    public Jwt Jwt { get; set; }
    public string AppName { get; set; }
    public DatabaseSetting DatabaseSetting { get; set; }
    public LdapInfo LdapInfo { get; set; }
    public UpdateVersion UpdateVersion { get; set; }
    public string SecretKey { get; set; }
    public string EncriptKey { get; set; }
    public List<object> LogUrlIgnores { get; set; }
    public string GateBankUrl { get; set; }
    public string GateBankCloseProfitAccountPath { get; set; }
    public string GateBankCloseAccountCallbackPath { get; set; }
    public Sanitizer Sanitizer { get; set; }
    public string Environment { get; set; }
    public string IsCheckUserPriviledge { get; set; }
    public OtelAppSettings OtelAppSettings { get; set; }
    public Redis Redis { get; set; }
    public S3 S3 { get; set; }
    public string gemboxLicense { get; set; }
    public string IsDebug { get; set; }
    public AwsSettings AwsSettings { get; set; }
}

public class AwsSettings
{
    public string EnableSecretsManager { get; set; }
    public string Region { get; set; }
    public string SecretName { get; set; }
}

public class DatabaseSetting
{
    public string ConnectionString { get; set; }
    public string ConnectionStringLog { get; set; }
    public string DatabaseType { get; set; }
}

public class Jwt
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public string TimeOut { get; set; }
}

public class LdapInfo
{
    public string searchBase { get; set; }
    public string domain { get; set; }
    public string searchRegion { get; set; }
    public string port { get; set; }
    public string user { get; set; }
    public string password { get; set; }
    public string useSSL { get; set; }
}

public class Logging
{
    public LogLevel LogLevel { get; set; }
}

public class LogLevel
{
    public string Default { get; set; }
    public string MicrosoftAspNetCore { get; set; }
}

public class OtelAppSettings
{
    public string ServiceName { get; set; }
    public string OtelEndpoint { get; set; }
    public int OtelProtocol { get; set; }
    public bool EnableOtel { get; set; }
    public int ExportInterval { get; set; }
}

public class Redis
{
    public string Redis_ServerIPAdress { get; set; }
    public string Redis_Auth { get; set; }
    public string Redis_DB_Number { get; set; }
}

public class S3
{
    public string Endpoint { get; set; }
    public string AccessKey { get; set; }
    public string SecretKeyS3 { get; set; }
    public string Bucket { get; set; }
}

public class Sanitizer
{
    public string SpecialCharactersPattern { get; set; }
}

public class UpdateVersion
{
    public string UpdatePath { get; set; }
}