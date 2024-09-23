export default {
    preset: 'ts-jest/presets/default-esm',
    testEnvironment: 'node',
    setupFiles: ['./tests/jest.setup.ts'],
    transform: {
      '^.+\\.ts?$': ['ts-jest', { useESM: true }],
    },
    extensionsToTreatAsEsm: ['.ts'],
    moduleNameMapper: {
      '^(\\.{1,2}/.*)\\.js$': '$1',
    },
  };
  