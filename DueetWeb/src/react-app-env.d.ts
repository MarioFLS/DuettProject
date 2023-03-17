/// <reference types="react-scripts" />

declare module 'TypeFruit' {
  export interface IFruit {
    description: string;
    id: number;
    name: string;
    tax: number;
    value: number;
  }
}