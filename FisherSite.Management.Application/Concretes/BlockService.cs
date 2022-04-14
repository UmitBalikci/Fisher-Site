using FisherSite.Domain;
using FisherSite.Management.Application.Abstracts;
using FisherSite.Management.Application.DTOs;
using FisherSite.Management.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Management.Application.Concretes
{
    public class BlockService : IBlockService
    {
        private readonly IBlockRepository _blockRepository;
        public BlockService(IBlockRepository blockRepository)
        {
            _blockRepository = blockRepository;
        }
        IEnumerable<BlockDTO> IBlockService.GetAll()
        {
            var blocks = _blockRepository.GetAll();
            var blockDTOs = new List<BlockDTO>();
            foreach (var block in blocks)
            {
                blockDTOs.Add(new BlockDTO()
                {
                    Id = block.Id,
                    Name = block.Name,
                });
            }
            return blockDTOs;
        }
    }
}
