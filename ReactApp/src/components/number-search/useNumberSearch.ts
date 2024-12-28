import { useState } from "react";
import { fetchNumberResult, INumberResult } from "./fetch-number-result";

export interface IUseNumberSearchReturn {
  result: INumberResult | null;
  error: string | null;
  loading: boolean;
  search: (number: number) => Promise<void>;
}

const useNumberSearch = (): IUseNumberSearchReturn => {
  const [result, setResult] = useState<INumberResult | null>(null);
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState<boolean>(false);

  const search = async (number: number): Promise<void> => {
    setLoading(true);
    setError(null);

    try {
      const data = await fetchNumberResult(number);
      setResult(data);
    } catch (err) {
      setError((err as Error).message);
    } finally {
      setLoading(false);
    }
  };

  return { result, error, loading, search };
};

export default useNumberSearch;
