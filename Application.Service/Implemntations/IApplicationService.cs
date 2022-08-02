using ApplicationModels.ViewModel;

namespace Application.Service.Implemntations
{
    public interface IApplicationService
    {
        Task<EnrollmentViewModel> Enrollment(EnrollmentViewModel model);
        Task<bool> CreateProfile(CreateUserViewModel model);
        Task<List<GetUserViewModel>> GetAllProfile();
        Task<GetUserViewModel> GetProfileById(int id);
        Task<UpdateUserViewModel> UpdateProfile(UpdateUserViewModel model);
        Task<bool> ActivateProfile(int id);
        Task<bool> DeactivateProfile(int id);

    }
}
