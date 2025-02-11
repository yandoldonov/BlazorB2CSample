namespace BlazorB2CSample.Settings;

public class AzureAdB2CSettings
{
    public string? Instance { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public string? Domain { get; set; }
    public string? SignUpSignInPolicyId { get; set; }
    public string? ResetPasswordPolicyId { get; set; }
    public string? EditProfilePolicyId { get; set; }
    public string? CallbackPath { get; set; }
    public string? SignedOutCallbackPath { get; set; }
    public string? TenantId { get; set; }
    public string? AzureAdLogoutPath { get; set; }
    public string? PostLogOutRedirectHost { get; set; }
    public string? AccessDeniedPath { get; set; }
}