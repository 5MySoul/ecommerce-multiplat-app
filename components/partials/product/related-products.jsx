import OwlCarousel from '~/components/features/owl-carousel';

import ProductTwo from '~/components/features/product/product-two';

import { relatedProductsSlider } from '~/utils/data/carousel';

export default function RelatedProducts ( props ) {
    const { products, adClass = "product-wrapper mb-4 mt-6" } = props;

    return (
        products.length > 0 ?
            <section className={ `${ adClass }` }>
                <h2 className="title mb-0 d-block text-center">Related Products</h2>

                <OwlCarousel adClass="owl-theme owl-nav-full owl-split" options={ relatedProductsSlider }>
                    {
                        products && products.slice( 0, 5 ).map( ( item, index ) =>
                            <ProductTwo product={ item } key={ 'product-two-' + index } isCat={ false } />
                        )
                    }
                </OwlCarousel>
            </section> : ''
    )
}