import { mount } from '@vue/test-utils';
import ProductList from '../ProductList.vue';
import axios from 'axios';

jest.mock('axios');
const mockedAxios = axios as jest.Mocked<typeof axios>;

describe('ProductList', () => {
  it('renders products from API', async () => {
    mockedAxios.get.mockResolvedValue({ data: [{ id:1, name: 'P1', price: 10 }] });
    const wrapper = mount(ProductList);
    await new Promise(process.nextTick);
    expect(wrapper.text()).toContain('P1');
    expect(mockedAxios.get).toHaveBeenCalled();
  });

  it('handles API error gracefully', async () => {
    mockedAxios.get.mockRejectedValue(new Error('Network error'));
    const wrapper = mount(ProductList);
    await new Promise(process.nextTick);
    expect(wrapper.text()).toContain('No products');
  });
});
