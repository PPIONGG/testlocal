namespace localizeTranslate.Services;

public interface IPortfolioDataService
{
    List<Job> GetJobs();
    List<Project> GetProjects();
    List<SkillCategory> GetSkills();
    List<EducationItem> GetEducation();
}

public class Job
{
    public string Title { get; set; } = "";
    public string Company { get; set; } = "";
    public string Period { get; set; } = "";
    public List<string> Details { get; set; } = new();
}

public class Project
{
    public string Title { get; set; } = "";
    public string Year { get; set; } = "";
    public string Description { get; set; } = "";
}

public class SkillCategory
{
    public string Name { get; set; } = "";
    public List<string> Items { get; set; } = new();
}

public class EducationItem
{
    public string Degree { get; set; } = "";
    public string School { get; set; } = "";
    public string Period { get; set; } = "";
}
