import { mount } from '@vue/test-utils';
import ProductList from '../ProductList.vue';
import axios from 'axios';

jest.mock('axios');
const mockedAxios = axios as jest.Mocked<typeof axios>;

test('snapshot', async () => {
  mockedAxios.get.mockResolvedValue({ data: [{ id:1, name: 'P1', price: 10 }] });
  const wrapper = mount(ProductList);
  await new Promise(process.nextTick);
  expect(wrapper.html()).toMatchSnapshot();
});
