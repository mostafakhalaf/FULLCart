import { FullCartTemplatePage } from './app.po';

describe('FullCart App', function() {
  let page: FullCartTemplatePage;

  beforeEach(() => {
    page = new FullCartTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
