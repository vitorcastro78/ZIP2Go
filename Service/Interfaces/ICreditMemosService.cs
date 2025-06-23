using Service.Models;

namespace Service
{
    public interface ICreditMemosService
    {
        CreditMemo ApplyCreditMemo(ApplyUnapplyCreditMemo body, string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo CancelCreditMemo(string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo CreateCreditMemo(CreditMemoCreateRequest body, string zuoraTrackId, bool? async);

        void DeleteCreditMemo(string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo GetCreditMemo(string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemoItemListResponse GetCreditMemoItems(string cursor, string zuoraTrackId, bool? async);

        CreditMemoListResponse GetCreditMemos(string cursor, string zuoraTrackId, bool? async);

        CreditMemo PatchCreditMemo(CreditMemoPatchRequest body, string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo PostCreditMemo(string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo UnapplyCreditMemo(ApplyUnapplyCreditMemo body, string creditMemoId, string zuoraTrackId, bool? async);

        CreditMemo UnpostCreditMemo(string creditMemoId, string zuoraTrackId, bool? async, string zuoraEntityId);
        CreditMemoListResponse GetCreditMemosCached();
        CreditMemo GetCreditMemoCached(string creditMemoId);
        void FillCreditMemosCache(string zuoraTrackId, bool async);
        void FillCreditMemosItemsCache(string zuoraTrackId, bool async);
    }
}