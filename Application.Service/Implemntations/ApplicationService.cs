using ApplicationModels.ViewModel;

namespace Application.Service.Implemntations
{
    public class ApplicationService: IApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<EnrollmentViewModel> Enrollment(EnrollmentViewModel model)
        {
            return default;
        }
        public async Task<bool> CreateProfile(CreateUserViewModel model)
        {
            return default;
        }

        public async Task<List<GetUserViewModel>> GetAllProfile()
        {
            return default;
        }
        public async Task<GetUserViewModel> GetProfileById(int id)
        {
            return default;
        }
        public async Task<UpdateUserViewModel> UpdateProfile(UpdateUserViewModel model)
        {
            return default;
        }

        public async Task<bool> ActivateProfile(int id)
        {
            return default;
        }
        public async Task<bool> DeactivateProfile(int id)
        {
            return default;
        }


    }
}
