using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionsService
    {
        /// <summary>
        /// Activate a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription ActivateSubscription(SubscriptionActivateRequest body, string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Cancel a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionCancelResponse CancelSubscription(CancelSubscriptionRequest body, string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Create a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription CreateSubscription(SubscriptionCreateRequest body, string zuoraTrackId, bool? async);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        void FillSubscriptionsCache(string zuoraTrackId, bool async);

        /// <summary>
        ///  Retrieve a subscription by its ID or number
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription GetSubscriptionByKey(string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Retrieve a subscription by its ID or number
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionVersionListResponse GetSubscriptionByVersion(string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Get Subscription Cached by ID
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <returns></returns>
        Subscription GetSubscriptionCached(string subscriptionId);

        /// <summary>
        /// Get Subscriptions
        /// </summary>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionListResponse GetSubscriptions(string zuoraTrackId, bool? async);

        /// <summary>
        /// Get Subscriptions Cached
        /// </summary>
        /// <returns></returns>
        SubscriptionListResponse GetSubscriptionsCached();

        /// <summary>
        /// Get Subscriptions by Account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        SubscriptionListResponse GetSubscriptionsCachedByAccountId(string accountId);

        /// <summary>
        /// Retrieve a subscription by its account ID
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionListResponse GetSubscriptionByAccountId(string accountId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Retrieve a subscription by its ID or number
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription PatchSubscription(SubscriptionPatchRequest body, string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Pause a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription PauseSubscription(PauseSubscriptionRequest body, string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Preview an existing subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionPreviewResponse PreviewExistingSubscription(SubscriptionPreviewExistingRequest body, string subscriptionId, string zuoraTrackId, bool? async);


        /// <summary>
        /// Preview a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionPreviewResponse PreviewSubscription(SubscriptionPreviewRequest body, string zuoraTrackId, bool? async);


        /// <summary>
        /// Resume a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription ResumeSubscription(ResumeSubscriptionRequest body, string subscriptionId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Uncancel a subscription
        /// </summary>
        /// <param name="body"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        Subscription UncancelSubscription(SubscriptionPatchRequest body, string subscriptionId, string zuoraTrackId, bool? async);
    }
}