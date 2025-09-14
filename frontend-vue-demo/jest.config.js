module.exports = {
  transform: {
    '^.+\\.vue$': 'vue-jest',
    '^.+\\.ts$': 'ts-jest'
  },
  moduleFileExtensions: ['js','ts','json','vue'],
  testEnvironment: 'jsdom'
};
