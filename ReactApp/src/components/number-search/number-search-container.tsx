import { NumberSearchView } from "./number-search-view";
import useNumberSearch from "./useNumberSearch";

export const NumberSearchContainer: React.FC = () => {
  const viewModel = useNumberSearch();
  return <NumberSearchView viewModel={viewModel} />;
};
