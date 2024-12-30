import { FC, useState } from "react";
import { IUseNumberSearchReturn } from "./useNumberSearch";

interface NumberSearchViewProps {
  viewModel: IUseNumberSearchReturn;
}

export const NumberSearchView: FC<NumberSearchViewProps> = ({ viewModel }) => {
  const [number, setNumber] = useState<string>("");

  const handleSearch = () => {
    if (number) {
      viewModel.search(BigInt(number));
    }
  };

  return (
    <div>
      <h1>Números divisores</h1>
      <input
        type="number"
        value={number}
        onChange={(e) => setNumber(e.target.value)}
        placeholder="Digite um número"
      />
      <button onClick={handleSearch} disabled={viewModel.loading}>
        {viewModel.loading ? "Buscando..." : "Buscar"}
      </button>
      {viewModel.error && <p style={{ color: "red" }}>{viewModel.error}</p>}
      {viewModel.result && (
        <div>
          <h2>Resultado:</h2>
          <p>Número: {viewModel.result.number}</p>
          <p>Divisores: {viewModel.result.divisors.join(", ")}</p>
          <p>Divisores Primos: {viewModel.result.primeDivisors.join(", ")}</p>
        </div>
      )}
    </div>
  );
};
