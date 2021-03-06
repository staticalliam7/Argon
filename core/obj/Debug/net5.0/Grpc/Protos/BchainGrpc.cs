// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Grpc/Protos/bchain.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class BChainService
  {
    static readonly string __ServiceName = "BChainService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcService.EmptyRequest> __Marshaller_EmptyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.EmptyRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService.BlockResponse> __Marshaller_BlockResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.BlockResponse.Parser));
    static readonly grpc::Marshaller<global::GrpcService.SendRequest> __Marshaller_SendRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.SendRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService.TrxResponse> __Marshaller_TrxResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.TrxResponse.Parser));
    static readonly grpc::Marshaller<global::GrpcService.BlockRequest> __Marshaller_BlockRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.BlockRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService.BlocksResponse> __Marshaller_BlocksResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.BlocksResponse.Parser));
    static readonly grpc::Marshaller<global::GrpcService.AccountRequest> __Marshaller_AccountRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.AccountRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcService.BalanceResponse> __Marshaller_BalanceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.BalanceResponse.Parser));
    static readonly grpc::Marshaller<global::GrpcService.TransactionsResponse> __Marshaller_TransactionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcService.TransactionsResponse.Parser));

    static readonly grpc::Method<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse> __Method_GenesisBlock = new grpc::Method<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenesisBlock",
        __Marshaller_EmptyRequest,
        __Marshaller_BlockResponse);

    static readonly grpc::Method<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse> __Method_LastBlock = new grpc::Method<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LastBlock",
        __Marshaller_EmptyRequest,
        __Marshaller_BlockResponse);

    static readonly grpc::Method<global::GrpcService.SendRequest, global::GrpcService.TrxResponse> __Method_SendCoin = new grpc::Method<global::GrpcService.SendRequest, global::GrpcService.TrxResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendCoin",
        __Marshaller_SendRequest,
        __Marshaller_TrxResponse);

    static readonly grpc::Method<global::GrpcService.BlockRequest, global::GrpcService.BlocksResponse> __Method_GetBlocks = new grpc::Method<global::GrpcService.BlockRequest, global::GrpcService.BlocksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBlocks",
        __Marshaller_BlockRequest,
        __Marshaller_BlocksResponse);

    static readonly grpc::Method<global::GrpcService.AccountRequest, global::GrpcService.BalanceResponse> __Method_GetBalance = new grpc::Method<global::GrpcService.AccountRequest, global::GrpcService.BalanceResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBalance",
        __Marshaller_AccountRequest,
        __Marshaller_BalanceResponse);

    static readonly grpc::Method<global::GrpcService.AccountRequest, global::GrpcService.TransactionsResponse> __Method_GetTransactions = new grpc::Method<global::GrpcService.AccountRequest, global::GrpcService.TransactionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTransactions",
        __Marshaller_AccountRequest,
        __Marshaller_TransactionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.BchainReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BChainService</summary>
    [grpc::BindServiceMethod(typeof(BChainService), "BindService")]
    public abstract partial class BChainServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.BlockResponse> GenesisBlock(global::GrpcService.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.BlockResponse> LastBlock(global::GrpcService.EmptyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.TrxResponse> SendCoin(global::GrpcService.SendRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.BlocksResponse> GetBlocks(global::GrpcService.BlockRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.BalanceResponse> GetBalance(global::GrpcService.AccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcService.TransactionsResponse> GetTransactions(global::GrpcService.AccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BChainServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GenesisBlock, serviceImpl.GenesisBlock)
          .AddMethod(__Method_LastBlock, serviceImpl.LastBlock)
          .AddMethod(__Method_SendCoin, serviceImpl.SendCoin)
          .AddMethod(__Method_GetBlocks, serviceImpl.GetBlocks)
          .AddMethod(__Method_GetBalance, serviceImpl.GetBalance)
          .AddMethod(__Method_GetTransactions, serviceImpl.GetTransactions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BChainServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GenesisBlock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse>(serviceImpl.GenesisBlock));
      serviceBinder.AddMethod(__Method_LastBlock, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.EmptyRequest, global::GrpcService.BlockResponse>(serviceImpl.LastBlock));
      serviceBinder.AddMethod(__Method_SendCoin, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.SendRequest, global::GrpcService.TrxResponse>(serviceImpl.SendCoin));
      serviceBinder.AddMethod(__Method_GetBlocks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.BlockRequest, global::GrpcService.BlocksResponse>(serviceImpl.GetBlocks));
      serviceBinder.AddMethod(__Method_GetBalance, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.AccountRequest, global::GrpcService.BalanceResponse>(serviceImpl.GetBalance));
      serviceBinder.AddMethod(__Method_GetTransactions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.AccountRequest, global::GrpcService.TransactionsResponse>(serviceImpl.GetTransactions));
    }

  }
}
#endregion
