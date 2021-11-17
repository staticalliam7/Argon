// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/bchain.proto
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

    /// <summary>Client for BChainService</summary>
    public partial class BChainServiceClient : grpc::ClientBase<BChainServiceClient>
    {
      /// <summary>Creates a new client for BChainService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BChainServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BChainService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BChainServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BChainServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BChainServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.BlockResponse GenesisBlock(global::GrpcService.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenesisBlock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.BlockResponse GenesisBlock(global::GrpcService.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenesisBlock, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlockResponse> GenesisBlockAsync(global::GrpcService.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenesisBlockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlockResponse> GenesisBlockAsync(global::GrpcService.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenesisBlock, null, options, request);
      }
      public virtual global::GrpcService.BlockResponse LastBlock(global::GrpcService.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LastBlock(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.BlockResponse LastBlock(global::GrpcService.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LastBlock, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlockResponse> LastBlockAsync(global::GrpcService.EmptyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LastBlockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlockResponse> LastBlockAsync(global::GrpcService.EmptyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LastBlock, null, options, request);
      }
      public virtual global::GrpcService.TrxResponse SendCoin(global::GrpcService.SendRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendCoin(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.TrxResponse SendCoin(global::GrpcService.SendRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendCoin, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.TrxResponse> SendCoinAsync(global::GrpcService.SendRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendCoinAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.TrxResponse> SendCoinAsync(global::GrpcService.SendRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendCoin, null, options, request);
      }
      public virtual global::GrpcService.BlocksResponse GetBlocks(global::GrpcService.BlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlocks(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.BlocksResponse GetBlocks(global::GrpcService.BlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBlocks, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlocksResponse> GetBlocksAsync(global::GrpcService.BlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlocksAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BlocksResponse> GetBlocksAsync(global::GrpcService.BlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBlocks, null, options, request);
      }
      public virtual global::GrpcService.BalanceResponse GetBalance(global::GrpcService.AccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBalance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.BalanceResponse GetBalance(global::GrpcService.AccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBalance, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BalanceResponse> GetBalanceAsync(global::GrpcService.AccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBalanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.BalanceResponse> GetBalanceAsync(global::GrpcService.AccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBalance, null, options, request);
      }
      public virtual global::GrpcService.TransactionsResponse GetTransactions(global::GrpcService.AccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTransactions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.TransactionsResponse GetTransactions(global::GrpcService.AccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTransactions, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.TransactionsResponse> GetTransactionsAsync(global::GrpcService.AccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTransactionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.TransactionsResponse> GetTransactionsAsync(global::GrpcService.AccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTransactions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BChainServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BChainServiceClient(configuration);
      }
    }

  }
}
#endregion