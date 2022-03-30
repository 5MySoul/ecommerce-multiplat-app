import React from 'react';
import Reveal from 'react-awesome-reveal';

import OwlCarousel from '~/components/features/owl-carousel';

import PostSix from '~/components/features/post/post-six';

import { fadeIn, fadeInUpShorter } from '~/utils/data/keyframes';
import { mainSlider5 } from '~/utils/data/carousel';

function BlogSection ( props ) {
    const { posts } = props;

    return (
        <section className="blog container mt-10 pt-3 mb-10">
            <Reveal keyframes={ fadeIn } duration={ 1000 } triggerOnce>
                <h2 className="title title-underline title-line mb-4">From our Blog</h2>

                <OwlCarousel adClass="owl-theme" options={ mainSlider5 }>
                    {
                        posts && posts.length ?
                            posts.slice( 15, 19 ).map( ( post, index ) => (
                                <React.Fragment key={ "post-six" + index }>
                                    <Reveal keyframes={ fadeInUpShorter } duration={ 1000 } delay={ index * 200 + 300 } triggerOnce>
                                        <PostSix post={ post } adClass="overlay-zoom" isCalender={ true } adClass="" isAuthor={ false } btnAdClass="btn-sm" btnText="Read More" isOriginal={ true } />
                                    </Reveal>
                                </React.Fragment>
                            ) ) : ''
                    }
                </OwlCarousel>
            </Reveal>
        </section>
    )
}

export default React.memo( BlogSection );