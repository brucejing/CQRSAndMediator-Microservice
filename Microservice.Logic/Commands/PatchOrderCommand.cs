﻿using MediatR;
using Microservice.Logic.Model;
using Microservice.Logic.Responses;
using Microsoft.AspNetCore.JsonPatch;

namespace Microservice.Logic.Commands
{
    public class PatchOrderCommand : IRequest<OrderResponse>
    {
        public long OrderId { get; }
        public long PersonId { get; }
        public JsonPatchDocument<OrderPatchModel> JsonPatchDocument { get; set; }

        public PatchOrderCommand(long orderId, long personId,JsonPatchDocument<OrderPatchModel> jsonPatchDocument )
        {
            OrderId = orderId;
            PersonId = personId;
            JsonPatchDocument = jsonPatchDocument;
        }
    }
}
