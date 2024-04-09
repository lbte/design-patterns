import clsx from 'clsx';
import Heading from '@theme/Heading';
import styles from './styles.module.css';

const FeatureList = [
  {
    title: 'Creational Patterns',
    Svg: require('@site/static/img/undraw_docusaurus_mountain.svg').default,
    description: (
      <>
        These patterns focus on the process of object creation, providing flexible ways to create objects while hiding the creation logic. 
        They ensure a system remains independent of how its objects are created, composed, and represented.
      </>
    ),
  },
  {
    title: 'Structural Patterns',
    Svg: require('@site/static/img/undraw_docusaurus_tree.svg').default,
    description: (
      <>
        Structural patterns deal with the composition of classes or objects to form larger structures. 
        They simplify design by identifying simple ways to realize relationships between entities, without changing their individual structures.
      </>
    ),
  },
  {
    title: 'Behavioral Patterns',
    Svg: require('@site/static/img/undraw_docusaurus_react.svg').default,
    description: (
      <>
        Behavioral patterns concentrate on object interaction, defining how objects communicate and collaborate. 
        They assign responsibilities between objects, enhancing flexibility and maintainability by making the system's behavior more predictable and adaptable.
      </>
    ),
  },
];

function Feature({Svg, title, description}) {
  return (
    <div className={clsx('col col--4')}>
      <div className="text--center">
        <Svg className={styles.featureSvg} role="img" />
      </div>
      <div className="text--center padding-horiz--md">
        <Heading as="h3">{title}</Heading>
        <p>{description}</p>
      </div>
    </div>
  );
}

export default function HomepageFeatures() {
  return (
    <section className={styles.features}>
      <div className="container">
        <div className="row">
          {FeatureList.map((props, idx) => (
            <Feature key={idx} {...props} />
          ))}
        </div>
      </div>
    </section>
  );
}
