﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestDeployedRModels
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for CarsService.
    /// </summary>
    public static partial class CarsServiceExtensions
    {
            /// <summary>
            /// Logs the user in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='loginRequest'>
            /// </param>
            public static AccessTokenResponse Login(this ICarsService operations, LoginRequest loginRequest)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).LoginAsync(loginRequest), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Logs the user in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='loginRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessTokenResponse> LoginAsync(this ICarsService operations, LoginRequest loginRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LoginWithHttpMessagesAsync(loginRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The user renews access token and refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='renewTokenRequest'>
            /// </param>
            public static AccessTokenResponse RenewToken(this ICarsService operations, RenewTokenRequest renewTokenRequest)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).RenewTokenAsync(renewTokenRequest), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The user renews access token and refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='renewTokenRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessTokenResponse> RenewTokenAsync(this ICarsService operations, RenewTokenRequest renewTokenRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RenewTokenWithHttpMessagesAsync(renewTokenRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The user revokes a refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refreshToken'>
            /// The refresh token to be revoked
            /// </param>
            public static AccessTokenResponse RevokeRefreshToken(this ICarsService operations, string refreshToken)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).RevokeRefreshTokenAsync(refreshToken), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The user revokes a refresh token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='refreshToken'>
            /// The refresh token to be revoked
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessTokenResponse> RevokeRefreshTokenAsync(this ICarsService operations, string refreshToken, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RevokeRefreshTokenWithHttpMessagesAsync(refreshToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Consume the carsService web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            public static WebServiceResult ManualTransmission(this ICarsService operations, InputParameters webServiceParameters)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).ManualTransmissionAsync(webServiceParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Consume the carsService web service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='webServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebServiceResult> ManualTransmissionAsync(this ICarsService operations, InputParameters webServiceParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ManualTransmissionWithHttpMessagesAsync(webServiceParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Consume the carsService web service asynchronously.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchWebServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='parallelCount'>
            /// Number of threads used to process entries in the batch. Default value is
            /// 10. Please make sure not to use too high of a number because it might
            /// negatively impact performance.
            /// </param>
            public static StartBatchExecutionResponse StartBatchExecution(this ICarsService operations, IList<InputParameters> batchWebServiceParameters, int? parallelCount = default(int?))
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).StartBatchExecutionAsync(batchWebServiceParameters, parallelCount), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Consume the carsService web service asynchronously.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='batchWebServiceParameters'>
            /// Input parameters to the web service.
            /// </param>
            /// <param name='parallelCount'>
            /// Number of threads used to process entries in the batch. Default value is
            /// 10. Please make sure not to use too high of a number because it might
            /// negatively impact performance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StartBatchExecutionResponse> StartBatchExecutionAsync(this ICarsService operations, IList<InputParameters> batchWebServiceParameters, int? parallelCount = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartBatchExecutionWithHttpMessagesAsync(batchWebServiceParameters, parallelCount, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> GetBatchExecutions(this ICarsService operations)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).GetBatchExecutionsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetBatchExecutionsAsync(this ICarsService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='showPartialResults'>
            /// Returns the already processed results of the batch execution even if it
            /// hasn't been fully completed.
            /// </param>
            public static BatchWebServiceResult GetBatchExecutionStatus(this ICarsService operations, string executionId, bool? showPartialResults = default(bool?))
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).GetBatchExecutionStatusAsync(executionId, showPartialResults), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='showPartialResults'>
            /// Returns the already processed results of the batch execution even if it
            /// hasn't been fully completed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BatchWebServiceResult> GetBatchExecutionStatusAsync(this ICarsService operations, string executionId, bool? showPartialResults = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionStatusWithHttpMessagesAsync(executionId, showPartialResults, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels and deletes all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution.
            /// </param>
            public static IList<string> CancelAndDeleteBatchExecution(this ICarsService operations, string executionId)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).CancelAndDeleteBatchExecutionAsync(executionId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels and deletes all batch executions for carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> CancelAndDeleteBatchExecutionAsync(this ICarsService operations, string executionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelAndDeleteBatchExecutionWithHttpMessagesAsync(executionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all files from an individual execution in carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            public static IList<string> GetBatchExecutionFiles(this ICarsService operations, string executionId, int index)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).GetBatchExecutionFilesAsync(executionId, index), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all files from an individual execution in carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetBatchExecutionFilesAsync(this ICarsService operations, string executionId, int index, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBatchExecutionFilesWithHttpMessagesAsync(executionId, index, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a specific file from an execution in carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='fileName'>
            /// Name of the file to be returned.
            /// </param>
            public static System.IO.Stream GetBatchExecutionFile(this ICarsService operations, string executionId, int index, string fileName)
            {
                return Task.Factory.StartNew(s => ((ICarsService)s).GetBatchExecutionFileAsync(executionId, index, fileName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a specific file from an execution in carsService.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='executionId'>
            /// Execution id of the execution
            /// </param>
            /// <param name='index'>
            /// Index of the execution in the batch.
            /// </param>
            /// <param name='fileName'>
            /// Name of the file to be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.IO.Stream> GetBatchExecutionFileAsync(this ICarsService operations, string executionId, int index, string fileName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetBatchExecutionFileWithHttpMessagesAsync(executionId, index, fileName, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

    }
}
