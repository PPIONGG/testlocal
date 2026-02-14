using System.Collections.Concurrent;
using System.Globalization;
using System.Text.Json;

namespace localizeTranslate.Services;

public class PortfolioDataService : IPortfolioDataService
{
    private static readonly ConcurrentDictionary<string, PortfolioLocaleData> Cache = new();
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    private readonly string _localesPath;

    public PortfolioDataService(IWebHostEnvironment env)
    {
        _localesPath = Path.Combine(env.ContentRootPath, "Locales");
    }

    public List<Job> GetJobs() => GetLocaleData().Jobs;
    public List<Project> GetProjects() => GetLocaleData().Projects;
    public List<SkillCategory> GetSkills() => GetLocaleData().Skills;
    public List<EducationItem> GetEducation() => GetLocaleData().Education;

    private PortfolioLocaleData GetLocaleData()
    {
        var culture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;

        return Cache.GetOrAdd(culture, key =>
        {
            var filePath = Path.Combine(_localesPath, $"{key}.json");

            if (!File.Exists(filePath))
                filePath = Path.Combine(_localesPath, "en.json");

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<PortfolioLocaleData>(json, JsonOptions) ?? new();
        });
    }
}
