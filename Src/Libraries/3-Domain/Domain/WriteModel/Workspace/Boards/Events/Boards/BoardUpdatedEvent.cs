﻿using TaskoMask.Domain.Core.Events;
using TaskoMask.Domain.WriteModel.Workspace.Boards.Entities;

namespace TaskoMask.Domain.WriteModel.Workspace.Boards.Events.Boards
{
    public class BoardUpdatedEvent : DomainEvent
    {
        public BoardUpdatedEvent(string id, string name, string description) : base(entityId: id, entityType: nameof(Board))
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Id { get; }
        public string Name { get;  }
        public string Description { get; }
    }
}
