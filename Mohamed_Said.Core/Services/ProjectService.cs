using AutoMapper;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.IServices;
using Mohamed_Said.Core.Interfaces.IUnitOfWork;
using Mohamed_Said.Shared.DTOs.AnonymousUser.Project;
using Mohamed_Said.Shared.DTOs.Admin.Project;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Mohamed_Said.Shared.Constants;

namespace Mohamed_Said.Core.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProjectService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // Anonymous
        public async Task<IEnumerable<ProjectDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.ProjectRepository.GetAllAsync(p => p.DisplayOrder, OrderBy.Ascending, ["ProjectSkills.Skill", "ProjectVideos", "ProjectImages"]);
            // include ProjectSkills to Projects . theninclude Skill to ProjectSkills . include ProjectVideos to Projects .include ProjectImages to Projects
            return _mapper.Map<IEnumerable<ProjectDto>>(entities);
        }

        public async Task<int> GetCountAsync()
        {
            return await _unitOfWork.ProjectRepository.CountAsync();
        }

        public async Task<ProjectDto?> GetByTitleAsync(string? projectTitle)
        {
            if (string.IsNullOrEmpty(projectTitle)) return null;

            var entity = await _unitOfWork.ProjectRepository.FindAsync( p => p.Title == projectTitle,
                                                                        ["ProjectVideos", "ProjectImages"]);

            return _mapper.Map<ProjectDto>(entity);
        }


        // Admin
        public async Task<IEnumerable<A_ProjectDto>> A_GetAllAsync()
        {
            var entities = await _unitOfWork.ProjectRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<A_ProjectDto>>(entities);
        }

        public async Task<A_ProjectDto?> A_GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.ProjectRepository.GetByIdAsync(id);
            return _mapper.Map<A_ProjectDto>(entity);
        }

        public async Task<A_ProjectDto?> AddAsync(A_ProjectDto dto)
        {
            var entity = _mapper.Map<Project>(dto);
            var added = _unitOfWork.ProjectRepository.Add(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(added);
        }

        public async Task<A_ProjectDto?> UpdateAsync(A_ProjectDto dto)
        {
            var entity = _mapper.Map<Project>(dto);
            var updated = _unitOfWork.ProjectRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(updated);
        }

        public async Task<A_ProjectDto?> DeleteAsync(int id)
        {
            var entity = await _unitOfWork.ProjectRepository.GetByIdAsync(id);
            if (entity == null) return null;
            var deleted = _unitOfWork.ProjectRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(deleted);
        }

        public async Task<A_ProjectDto?> AddSkillAsync(int projectId, A_ProjectSkillDto skillDto)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var skill = _mapper.Map<ProjectSkill>(skillDto);
            project.ProjectSkills.Add(skill);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }

        public async Task<A_ProjectDto?> RemoveSkillAsync(int projectId, int skillId)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var skill = project.ProjectSkills.FirstOrDefault(s => s.SkillId == skillId);
            if (skill == null) return null;

            project.ProjectSkills.Remove(skill);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }

        public async Task<A_ProjectDto?> AddImageAsync(int projectId, A_ProjectImageDto imageDto)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var image = _mapper.Map<ProjectImage>(imageDto);
            project.ProjectImages.Add(image);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }

        public async Task<A_ProjectDto?> RemoveImageAsync(int projectId, int imageId)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var image = project.ProjectImages.FirstOrDefault(i => i.Id == imageId);
            if (image == null) return null;

            project.ProjectImages.Remove(image);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }

        public async Task<A_ProjectDto?> AddVideoAsync(int projectId, A_ProjectVideoDto videoDto)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var video = _mapper.Map<ProjectVideo>(videoDto);
            project.ProjectVideos.Add(video);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }

        public async Task<A_ProjectDto?> RemoveVideoAsync(int projectId, int videoId)
        {
            var project = await _unitOfWork.ProjectRepository.GetByIdAsync(projectId);
            if (project == null) return null;

            var video = project.ProjectVideos.FirstOrDefault(v => v.Id == videoId);
            if (video == null) return null;

            project.ProjectVideos.Remove(video);
            await _unitOfWork.CompleteAsync();
            return _mapper.Map<A_ProjectDto>(project);
        }
    }
}
