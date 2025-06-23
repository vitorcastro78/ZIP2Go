using Service.Models;

namespace Service.Interfaces
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISubscriptionPlansService
    {
        /// <summary>
        /// Get a subscription plan Returns a single subscription plan object. If the specified subscription plan does not exist, this request returns a 404 error. This request should never return an error.
        /// </summary>
        /// <param name="subscriptionPlanId"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionPlan GetSubscriptionPlan(string subscriptionPlanId, string zuoraTrackId, bool? async);

        /// <summary>
        /// Get a list of subscription plans Returns a list of subscription plan objects. If the specified subscription plan does not exist, this request returns an empty array. This request should never return an error.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="zuoraTrackId"></param>
        /// <param name="async"></param>
        /// <returns></returns>
        SubscriptionPlanListResponse GetSubscriptionPlans(string zuoraTrackId, bool? async);
        SubscriptionPlanListResponse GetSubscriptionPlansCached();
        SubscriptionPlan GetSubscriptionPlanCached(string subscriptionPlanId);
        void FillSubscriptionPlansCached();
    }
}