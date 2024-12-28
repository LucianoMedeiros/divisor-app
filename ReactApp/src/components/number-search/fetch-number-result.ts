import axios from "axios";

export interface INumberResult {
  number: number;
  divisors: number[];
  primeDivisors: number[];
}

export const fetchNumberResult = async (
  number: number
): Promise<INumberResult> => {
  try {
    const response = await axios.get<INumberResult>(
      `https://localhost:7012/Divisor/${number}`
    );
    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error) && error.response) {
      // Caso o erro seja uma resposta de erro da API
      throw new Error(
        `Erro na API: ${error.response.status} - ${error.response.statusText}`
      );
    } else {
      // Caso o erro não seja uma resposta da API
      throw new Error("Número não encontrado");
    }
  }
};
