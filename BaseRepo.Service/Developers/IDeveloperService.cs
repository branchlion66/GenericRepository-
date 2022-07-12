using BaseRepo.Entity;

namespace BaseRepo.Service.Developers
{
    public interface IDeveloperService
    {
        List<Developer> Developers();
        List<Project> Projects();
    }
}